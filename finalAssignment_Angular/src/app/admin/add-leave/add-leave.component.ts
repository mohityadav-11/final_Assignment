import { Component, OnInit } from '@angular/core';
import { LeaveService } from 'src/app/shared/leave.service';
import { NgForm } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { Leave } from 'src/app/shared/leave.model';

@Component({
  selector: 'app-add-leave',
  templateUrl: './add-leave.component.html',
  styleUrls: ['./add-leave.component.css']
})
export class AddLeaveComponent implements OnInit {

  id:number;

  constructor(private router: Router,
    private route: ActivatedRoute,
    public service: LeaveService) { }

    ngOnInit(): void {
      this.id = +this.route.snapshot.paramMap.get('id');
      if(this.id===0)
        this.resetForm();
      else{
        this.service.getLeaveById(this.id);
      }
    }

    resetForm(form?:NgForm){
      if(form != null)
        form.resetForm();
      this.service.leave = {
        leaveId: 0,
        leaveMaxNoOfDays: null,
        leaveName: ""
      }
    }

  saveLeaveData(form: Leave,fm: NgForm){
    if(this.id===0){
      this.service.postLeaveData(fm.value).subscribe(
        res => {
          this.resetForm(fm);
        },
        err => console.log(err)
      );
    }else{
      this.service.updateLeaveData(this.id,form).subscribe(
        res => this.resetForm(fm)
      );
    }
    this.router.navigate(['/admin/leaveConfig']).then(() => {
      window.location.reload();
    });
  }

}
