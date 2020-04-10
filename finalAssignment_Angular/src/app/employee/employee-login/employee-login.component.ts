import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employee-login',
  templateUrl: './employee-login.component.html',
  styleUrls: ['./employee-login.component.css']
})
export class EmployeeLoginComponent implements OnInit {

  fieldData: string;
  count:number;

  constructor(private service: EmployeeService,
    private router: Router) { }

  ngOnInit(): void {
    this.service.getAllEmployees();
  }

  verifyEmployee(){
    this.count=0;
    for(let data of this.service.empList){
      if(data.employeeEmail === this.fieldData){
        this.count++;
        this.router.navigate(['/employee/'+data.emplyeeId]);
      }
    }
    if(this.count===0){
      alert("Employee not found");
    }
  }

}
