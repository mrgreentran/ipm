import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { ModalModule } from 'ngx-bootstrap/modal';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { SkillComponent } from './components/skill/skill.component';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { UiSwitchModule } from 'angular2-ui-switch';
//Provider
import { ConfigUrl } from './service/url/urlConfig';
import { SkillService } from './service/skill/skill.service';
import { ListSkill } from './entities/skill';
import { Message } from './entities/message';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        SkillComponent,
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        PaginationModule.forRoot(),
        ModalModule.forRoot(),
        UiSwitchModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'skill', component: SkillComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [SkillService, ListSkill, ConfigUrl, Message]
    
})
export class AppModuleShared {
}
