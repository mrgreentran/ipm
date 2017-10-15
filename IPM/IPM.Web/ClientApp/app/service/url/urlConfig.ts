import { Inject } from '@angular/core';

export class ConfigUrl {
    constructor( @Inject('BASE_URL') public baseUrl: string) {

    }

    //#region url of skill

    //link url api to get list page and search from web api
    public UrlGetListPageSkill(pageNumber: number, pageSize: number, keySearch: string): string {
        return this.baseUrl + `api/Skill/GetListPageSkill?pageNumber=${pageNumber}&pageSize=${pageSize}&keySearch=${keySearch}`;
    }

    //link url to insert skill to from web api
    public UrlInsertSkill(): string {
        return this.baseUrl + `api/Skill/InsertSkill`;
    }

    //link url to get one skill to from web api
    public UrlGetOneSkill(id: number): string {
        return this.baseUrl + `api/Skill/GetOneSkill?id=${id}`;
    }

    //link url to update active skill to from web api
    public UrlDeleteSkill(id: number): string {
        return this.baseUrl + `api/Skill/DeleteSkill?id=${id}`;
    }

    //link url to update skill to from web api
    public UrlUpdateSkill(): string {
        return this.baseUrl + `api/Skill/UpdateSkill`;
    }

    //#endregion

}