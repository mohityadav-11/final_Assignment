import { Injectable } from '@angular/core';
import { Leave } from './leave.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LeaveService {

  formData: Leave;
  readonly databaseUrl ="http://localhost:59275/api/leaves";
  leaveList: Leave[];
  leave: Leave;

  constructor(private http: HttpClient) { }

  postLeaveData(formData: Leave){
    return this.http.post(this.databaseUrl,formData);
  }

  updateLeaveData(id:number,formData: Leave){
    return this.http.put(this.databaseUrl+"/"+id,formData);
  }


  getAllLeaves(){
    this.http.get(this.databaseUrl)
    .toPromise()
    .then(result => this.leaveList = result as Leave[]);
  }

  getLeaveById(id: number){
    this.http.get(this.databaseUrl + '/'+id).subscribe(result => {
      this.leave = result as Leave;
  }, error => console.error(error));
  }

  deleteLeave(id:number){
    return this.http.delete(this.databaseUrl+'/'+id);
  }

}
