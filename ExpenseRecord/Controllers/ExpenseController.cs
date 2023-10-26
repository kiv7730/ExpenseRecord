using ExpenseRecord.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ExpenseRecord.Controllers;

[ApiController]
[Route("[controller]")]
public class ExpenseController : ControllerBase
{
    private static List<Expense> expenses = new List<Expense>() { new Expense(0,"SFDS","SDF",200, DateTime.Now)};

    [HttpGet]
    public ActionResult<IEnumerable<Expense>> Get()
    {
        return Ok(expenses);
    }

    [HttpPost]
    public ActionResult Post( Expense expense)
    {
        //Expense expense = JsonSerializer.Deserialize<Expense>(expense);
       // Expense expense = new Expense(id, de, type, amount, date);
        expenses.Insert(0, expense); // Adding to the top
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
