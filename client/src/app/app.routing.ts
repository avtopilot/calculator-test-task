import { HistoryComponent } from './history/history.component';
import { RouterModule, Routes } from '@angular/router';
import { CalculatorComponent } from './calculator/calculator.component';
import { AboutComponent } from './about/about.component';

const routes: Routes = [
  { path: '', component: CalculatorComponent },
  { path: 'about', component: AboutComponent},
  { path: 'history', component: HistoryComponent},
];

export const routing = RouterModule.forRoot(routes);
