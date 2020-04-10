import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/shared/employee.model';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  id:number;

  constructor(private router: Router,
    private route: ActivatedRoute,
    public service: EmployeeService) { }

  ngOnInit(): void {
    this.id = +this.route.snapshot.paramMap.get('id');
    if(this.id===0)
      this.resetForm();
    else{
      this.service.getEmployeeById(this.id);
      console.log(this.service.employee.emplyeeId);
    }
  }

  resetForm(form?:NgForm){
    if(form != null)
      form.resetForm();
    this.service.employee = {
      emplyeeId: 0,
      employeeName: "",
      employeeEmail: "",
      employeeDob: "",
      employeeDoj: ""
    }
  }

  saveEmp(form: Employee,fm: NgForm){
    if(this.id===0){
      this.service.postEmployeeData(fm.value).subscribe(
        res => {
          this.resetForm(fm);
        },
        err => console.log(err)
      );
    }else{
      this.service.updateEmployeeData(this.id,form).subscribe(
        res => this.resetForm(fm)
      );
    }
    this.router.navigate(['/admin/employeeList']).then(() => {
      window.location.reload();
    });
  }

}
