import { Injectable } from '@angular/core';
import { Employee } from './employee.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  formData: Employee;
  readonly databaseUrl ="http://localhost:59275/api/employees";
  empList: Employee[];
  employee: Employee;

  constructor(private http: HttpClient) { }

  postEmployeeData(formData: Employee){
    return this.http.post(this.databaseUrl,formData);
  }

  updateEmployeeData(id:number,formData: Employee){
    return this.http.put(this.databaseUrl+"/"+id,formData);
  }

  getAllEmployees(){
    this.http.get(this.databaseUrl)
    .toPromise()
    .then(result => this.empList = result as Employee[]);
  }

  getEmployeeById(id: number){
    this.http.get(this.databaseUrl + '/'+id).subscribe(result => {
      this.employee = result as Employee;
  }, error => console.error(error));
  }

  deleteEmployee(id:number){
    return this.http.delete(this.databaseUrl+'/'+id);
  }

}
