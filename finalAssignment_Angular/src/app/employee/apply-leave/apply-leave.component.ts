import { Component, OnInit } from '@angular/core';
import { LeaveService } from 'src/app/shared/leave.service';

@Component({
  selector: 'app-apply-leave',
  templateUrl: './apply-leave.component.html',
  styleUrls: ['./apply-leave.component.css']
})
export class ApplyLeaveComponent implements OnInit {

  constructor(public leaveService: LeaveService) { }

  ngOnInit(): void {
    this.leaveService.getAllLeaves();
  }

}
