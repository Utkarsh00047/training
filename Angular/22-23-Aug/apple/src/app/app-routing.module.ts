import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FirstSectionComponent } from './first-section/first-section.component';

const routes: Routes = [
  {path:'',component:FirstSectionComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
