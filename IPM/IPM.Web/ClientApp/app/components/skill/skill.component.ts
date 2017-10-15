import { Component, Inject, TemplateRef  } from '@angular/core';
import { Skill, ListSkill } from '../../entities/skill';
import { Message } from '../../entities/message';
import { Http } from '@angular/http';
import { Validators, FormBuilder, FormGroup } from '@angular/forms';
import { SkillService } from '../../service/skill/skill.service';
import { BsModalService } from 'ngx-bootstrap/modal';
import { BsModalRef } from 'ngx-bootstrap/modal/modal-options.class';


@Component({
    selector: 'skill',
    templateUrl: './skill.component.html',
    styleUrls: ['./skill.component.css']
})

export class SkillComponent { 

    private pageSize: number = 5;
    private pageNumber: number = 1;
    private keySearch: string = '';
    private listData: ListSkill;
    private listPageSkill: Skill[];
    private skill: Skill;
    private totalItems: number;
    private itemsPerPage: number;
    public modalRef: BsModalRef;
    private complexForm: FormGroup;


    constructor(private skillService: SkillService, private message: Message, private modalService: BsModalService) {
        this.onInit();
    
    }

    onInit() {
        this.skill = new Skill();
        this.listPageSkill = [];
        this.listData = new ListSkill();
        this.loadListPageSkill();        
    }

    loadListPageSkill() {
        this.skillService.GetListPageSkill(this.pageNumber, this.pageSize, this.keySearch).subscribe((response: ListSkill) => {
            this.listData = response;         
            if (this.listData.listData)
            {
                this.listPageSkill = this.listData.listData;
                let total = this.listPageSkill.length;
                this.totalItems = this.listPageSkill[total - 1].totalRow;
                this.itemsPerPage = this.totalItems / this.pageSize;
            }
            else {
                this.listPageSkill = this.listData.listData;
                let total = 2;
                this.totalItems = 1;
                this.itemsPerPage = this.totalItems / this.pageSize;
            }
        });
        
    }
    searchSkill() {
        this.pageNumber = 1;
        this.loadListPageSkill();
    }

    pageChanged(event: any): void {
        this.skillService.GetListPageSkill(event.page, this.pageSize, this.keySearch).subscribe((response: any) => {
            this.listData = response;
            this.listPageSkill = this.listData.listData;
        });       
    }

    saveSkill() {
        this.skill.Active = true;
        this.skillService.InsertSkill(this.skill).subscribe((response: Message) => {
            this.message = response;
        });
        this.pageNumber = 1;
        this.loadListPageSkill();
        
    }

    detailSkill(template: TemplateRef<any>, id: number) {
        this.skillService.GetOneSkillById(id).subscribe((response: Skill) => {
            this.skill = response;         
        });
        this.modalRef = this.modalService.show(template);
    } 

    deleteSkill(id: number) {
        let checkDelete = confirm('Are you sure delete this skill?');
        if (checkDelete) {
            this.skillService.DeleteSkill(id).subscribe((response: Message) => {
                this.message = response;
                console.log(this.message);
                this.pageNumber = 1;
                this.loadListPageSkill();
            });
        }
    }

    updateSkill(template: TemplateRef<any>, id: number) {
        this.skillService.GetOneSkillById(id).subscribe((response: Skill) => {
            this.skill = response;
        });
        this.modalRef = this.modalService.show(template);
    }

    saveUpdate(template: TemplateRef<any>) {
        console.log(this.skill.Active);
        this.skillService.UpdateSkill(this.skill).subscribe((response: Message) => {
            console.log(response);
            this.pageNumber = 1;
            this.loadListPageSkill();
            this.modalRef.hide();
        });
    }
}