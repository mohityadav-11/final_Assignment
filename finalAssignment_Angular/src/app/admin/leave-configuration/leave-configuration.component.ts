import { Component, OnInit } from '@angular/core';
import { LeaveService } from 'src/app/shared/leave.service';

@Component({
  selector: 'app-leave-configuration',
  templateUrl: './leave-configuration.component.html',
  styleUrls: ['./leave-configuration.component.css']
})
export class LeaveConfigurationComponent implements OnInit {

  constructor(public service: LeaveService) { }

  ngOnInit(): void {
    this.service.getAllLeaves();
  }

  deleteLeave(id:number){
    this.service.deleteLeave(id).subscribe(
      res => {
        this.service.getAllLeaves();
      },
      err => console.log(err)
    );
  }
}
