import { Injectable } from '@angular/core';
import { ListSkill, Skill } from '../../entities/skill';
import { Message } from '../../entities/message';
import { Observable } from 'rxjs/Observable';
import { Http, Response } from '@angular/http';
import { ConfigUrl } from '../url/urlConfig';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()

export class SkillService  {
    // Init link web api, list data, http
    constructor(private listData: ListSkill, private http: Http, private url: ConfigUrl) {
    }

    // Get data skill page and search
    // Return list data: list skill, message
    GetListPageSkill(pageNumber: number, pageSize: number, keySearch: string): Observable<ListSkill> {
        return this.http.get(this.url.UrlGetListPageSkill(pageNumber, pageSize, keySearch)).map((res: Response) => res.json());
    }

    // Insert skill 
    // Return message notificate
    InsertSkill(skill: Skill): Observable<Message> {
        return this.http.post(this.url.UrlInsertSkill(), skill).map((res: Response) => res.json());
    };

    //Get one skill by id
    GetOneSkillById(id: number): Observable<Skill> {
        return this.http.get(this.url.UrlGetOneSkill(id)).map((res: Response) => res.json());
    }

    //Delete Skill
    DeleteSkill(id: number): Observable<Message> {
        return this.http.delete(this.url.UrlDeleteSkill(id)).map((res: Response) => res.json());
    }

    //Update Skill
    UpdateSkill(skill: Skill): Observable<Message> {
        return this.http.put(this.url.UrlUpdateSkill(), skill).map((res: Response) => res.json());
    }
}