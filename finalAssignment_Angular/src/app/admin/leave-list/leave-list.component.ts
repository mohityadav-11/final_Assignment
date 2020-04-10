import { Component, OnInit } from '@angular/core';
import { EmpLeaveMapService } from 'src/app/shared/emp-leave-map.service';
import { EmployeeService } from 'src/app/shared/employee.service';
import { LeaveService } from 'src/app/shared/leave.service';

@Component({
  selector: 'app-leave-list',
  templateUrl: './leave-list.component.html',
  styleUrls: ['./leave-list.component.css']
})
export class LeaveListComponent implements OnInit {


  constructor(public elmservice: EmpLeaveMapService) { }

  ngOnInit(): void {
    this.elmservice.getAllEmpLeaveMaps();
  }

}
