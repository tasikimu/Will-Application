import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './component/login/login.component';
import { HomePageComponent } from './component/home-page/home-page.component';
import { WillTypesComponent } from './component/will-types/will-types.component';
import { UserDetailsComponent } from './component/user-details/user-details.component';
import { BeneficiariesComponent } from './component/beneficiaries/beneficiaries.component';
import { EstateExcComponent } from './component/estate-exc/estate-exc.component';
import { SubmitComponent } from './component/submit/submit.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomePageComponent,
    WillTypesComponent,
    UserDetailsComponent,
    BeneficiariesComponent,
    EstateExcComponent,
    SubmitComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
