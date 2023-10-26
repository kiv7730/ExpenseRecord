import { Component, Inject,OnInit } from '@angular/core';
import { Expense } from './model/expense';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-expense-cmnt',
  templateUrl: './expense-cmnt.component.html',
  styleUrls: ['./expense-cmnt.component.css']
})
export class ExpenseCmntComponent implements OnInit {

  expenses: Expense[] = [];

  private baseUrl: string;
  private http: HttpClient;




  constructor(
    http: HttpClient, 
    @Inject('BASE_URL') baseUrl: string) 
    { 
      this.http = http;
      this.baseUrl = baseUrl;
    }

  ngOnInit() {
    this.loadExpenses();
  }

  loadExpenses() {
    // this.expenseService.getExpenses().subscribe(data => {
    //   this.expenses = data;
    // });

    this.http.get<string>('https://localhost:7081/expense')
      .subscribe((result: any) => {
        this.expenses =result
      }, (error: any) => console.error(error));
  }

  addExpense(expense:any) {
    // id:number, description: string,  type: string,amount: number, date: string
  //  const expense= {id :id, description : description, type:type, amount :amount,date:date}
    // this.expenseService.addExpense(expense).subscribe(() => {
    //   this.expenses.unshift(expense);
    // });
    // const postvalue=;
    this.http.post('https://localhost:7081/expense', {id:expense.id, description:expense.description, type:expense.type, amount:expense.amount, date:expense.date})
      .subscribe(() => {this.loadExpenses();
        
      }, (error: any) => console.error(error));
      // this.http.get<string>('https://localhost:7081/expense/'+expense.id+'/'+expense.description+'/'+expense.type+'/'+expense.amount+'/'+expense.date)
      // .subscribe((result: any) => {
      //   this.loadExpenses();
      // }, (error: any) => console.error(error));
  }

  deleteExpense(id: number) {
    this.http.delete(`https://localhost:7081/expense/${id}`).subscribe(() => this.loadExpenses());
     
  }

}












