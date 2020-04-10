import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AdminComponent } from './admin/admin.component';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { EmployeeListComponent } from './admin/employee-list/employee-list.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { LeaveConfigurationComponent } from './admin/leave-configuration/leave-configuration.component';
import { LeaveListComponent } from './admin/leave-list/leave-list.component';
import { AddEmployeeComponent } from './admin/add-employee/add-employee.component';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { AddLeaveComponent } from './admin/add-leave/add-leave.component';
import { EmployeeLoginComponent } from './employee/employee-login/employee-login.component';
import { EmployeeComponent } from './employee/employee.component';
import { EmpLeaveListComponent } from './employee/emp-leave-list/emp-leave-list.component';
import { ApplyLeaveComponent } from './employee/apply-leave/apply-leave.component';
import { AdminLoginComponent } from './admin/admin-login/admin-login.component';
import { EmployeeService } from './shared/employee.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ModalModule, BsModalRef } from 'ngx-bootstrap/modal';




@NgModule({
  declarations: [
    AppComponent,
    AdminComponent,
    EmployeeListComponent,
    WelcomeComponent,
    LeaveConfigurationComponent,
    LeaveListComponent,
    AddEmployeeComponent,
    AddLeaveComponent,
    EmployeeLoginComponent,
    EmployeeComponent,
    EmpLeaveListComponent,
    ApplyLeaveComponent,
    AdminLoginComponent,
  ],
  imports: [
    BrowserModule,
    CommonModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    TabsModule.forRoot(),
    BsDatepickerModule.forRoot(),
    FormsModule,
    HttpClientModule,
    ModalModule.forRoot()

  ],
  providers: [EmployeeService,BsModalRef],
  bootstrap: [AppComponent]
})
export class AppModule { }
