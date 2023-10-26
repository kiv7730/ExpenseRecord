using ExpenseRecord.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Json;
namespace ExpenseRecord.Controllers;

public class TestModel
{
    public int Id { get; set; }
    public string description { get; set; }
}

public class Expense
{
   
    public int id { get; set; }
    public string description { get; set; }
    public string type { get; set; }
    public decimal amount { get; set; }
    public DateTime date { get; set; }
    //fuck !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
   /* public Expense(int id, string des, string type, decimal amo, DateTime date)
    {
        this.id = id;
        this.description = des;
        this.type = type;
        this.amount = amo;
        this.date = date;

    }*/
}

[ApiController]
//[Produces("application/json")]
[Route("[controller]")]
public class ExpenseController : ControllerBase
{
    private static List<Expense> expenses = new List<Expense>() { 
        //new Expense(0,"SFDS","SDF",200, DateTime.Now)
    };

    [HttpGet]
    public ActionResult<IEnumerable<Expense>> Get()
    {
        return Ok(expenses);
    }

    [HttpPost("ppp")]
    public ActionResult Post( [FromBody]Expense expense)
    {
        //Expense expense = JsonSerializer.Deserialize<Expense>(expense);
       // Expense expense = new Expense(id, de, type, amount, date);
        expenses.Insert(0, expense); // Adding to the top
        return Ok();
    }

    [HttpPost("test")]
    public ActionResult sometest([FromBody]TestModel tm) { 
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var expense = expenses.FirstOrDefault(e => e.id == id);
        if (expense != null)
        {
            expenses.Remove(expense);
            return Ok();
        }

        return NotFound();
    }
}
