export interface Expense {
  id: number;
  description: string;
  type: string;
  amount: number;
  date: string; // ISO format yyyy-MM-dd
}
