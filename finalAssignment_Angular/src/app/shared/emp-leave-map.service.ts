import { Injectable } from '@angular/core';
import { EmpLeaveMap } from './emp-leave-map.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmpLeaveMapService {

  formData: EmpLeaveMap;
  readonly databaseUrl ="http://localhost:59275/api/EmpLeaveMaps";
  empLeaveMapList: EmpLeaveMap[];
  empLeaveMap: EmpLeaveMap;
  i:number;
  day: number;
  mm: number;
  yy: number;

  constructor(private http: HttpClient) { }

  postEmpLeaveMapData(formData: EmpLeaveMap){
    return this.http.post(this.databaseUrl,formData);
  }

  getNoOfDays(){
    for(this.i=0;this.i<this.empLeaveMapList.length;this.i++){
      console.log(this.empLeaveMapList[this.i].leaveStartDate);
    }
  }

  getAllEmpLeaveMaps(){
    this.http.get(this.databaseUrl)
    .toPromise()
    .then(result => this.empLeaveMapList = result as EmpLeaveMap[]);
  }

  updateEmpLeaveMapData(id:number,formData: EmpLeaveMap){
    return this.http.put(this.databaseUrl+"/"+id,formData);
  }

  getEmpLeaveMapById(id: number){
    this.http.get(this.databaseUrl + '/'+id).subscribe(result => {
      this.empLeaveMap = result as EmpLeaveMap;
  }, error => console.error(error));
  }

  deleteEmpLeaveMap(id:number){
    return this.http.delete(this.databaseUrl+'/'+id);
  }
}
