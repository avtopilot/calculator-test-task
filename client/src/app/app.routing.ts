import { HistoryComponent } from './history/history.component';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'about', component: AboutComponent},
  { path: 'history', component: HistoryComponent},
];

export const routing = RouterModule.forRoot(routes);