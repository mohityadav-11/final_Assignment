import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { Employee } from 'src/app/shared/employee.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  constructor(public service:EmployeeService,
    private router: Router) { }

  ngOnInit(): void {
    this.service.getAllEmployees();
  }

  deletedEmp(id:number){
    this.service.deleteEmployee(id).subscribe(
      res => {
        this.service.getAllEmployees();
      },
      err => console.log(err)
    );
  }
}
