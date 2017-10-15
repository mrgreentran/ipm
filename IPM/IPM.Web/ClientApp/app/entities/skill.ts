import { IListData } from '../entities/IListData';

export class Skill {
    public id: number;
    public Name: string;
    public Active: boolean;
    public totalRow: number;
}

export class ListSkill implements IListData<Skill> {
    public listData: Skill[];
    public content: string;
    public alert: string;
    public static: boolean;
}