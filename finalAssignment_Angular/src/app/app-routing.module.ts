import {  NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { EmployeeListComponent } from './admin/employee-list/employee-list.component';
import { LeaveConfigurationComponent } from './admin/leave-configuration/leave-configuration.component';
import { LeaveListComponent } from './admin/leave-list/leave-list.component';
import { AddEmployeeComponent } from './admin/add-employee/add-employee.component';
import { AddLeaveComponent } from './admin/add-leave/add-leave.component';
import { EmployeeLoginComponent } from './employee/employee-login/employee-login.component';
import { EmployeeComponent } from './employee/employee.component';
import { ApplyLeaveComponent } from './employee/apply-leave/apply-leave.component';
import { EmpLeaveListComponent } from './employee/emp-leave-list/emp-leave-list.component';
import { AdminLoginComponent } from './admin/admin-login/admin-login.component';

@NgModule({
imports: [
  RouterModule.forRoot([
    { path: 'employee/:id', component: EmployeeComponent, children:[
      { path: 'apply', component: ApplyLeaveComponent },
      { path: 'empLeaveList', component: EmpLeaveListComponent },
      { path: '', pathMatch: 'full', redirectTo: 'empLeaveList' },
    ] },
    { path: 'adminLogin', component: AdminLoginComponent },
    { path: 'empLogin', component: EmployeeLoginComponent },
    { path: 'admin', component: AdminComponent, children: [
      { path: 'leaveList', component: LeaveListComponent },
      { path: 'leaveConfig', component: LeaveConfigurationComponent },
      { path: 'employeeList', component: EmployeeListComponent },
      { path: '', pathMatch: 'full', redirectTo: 'employeeList' },
    ] },
    { path: 'addLeave/:id', component: AddLeaveComponent },
    { path: 'addEmp/:id', component: AddEmployeeComponent },
    { path: 'welcome', component: WelcomeComponent },
    { path: '', pathMatch: 'full', redirectTo: 'welcome' },
    { path: '**', component: WelcomeComponent }
  ])
],
exports: [
  RouterModule
]
})

export class AppRoutingModule { }
