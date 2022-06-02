import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BeneficiariesComponent } from './component/beneficiaries/beneficiaries.component';
import { EstateExcComponent } from './component/estate-exc/estate-exc.component';
import { HomePageComponent } from './component/home-page/home-page.component';
import { LoginComponent } from './component/login/login.component';
import { SubmitComponent } from './component/submit/submit.component';
import { UserDetailsComponent } from './component/user-details/user-details.component';
import { WillTypesComponent } from './component/will-types/will-types.component';

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'home-page', component: HomePageComponent},
  {path: 'user-details', component: UserDetailsComponent},
  {path: 'will-types', component: WillTypesComponent},
  {path: 'submit', component: SubmitComponent},
  {path: 'estate', component: EstateExcComponent},
  {path: 'beneficiaries', component: BeneficiariesComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
