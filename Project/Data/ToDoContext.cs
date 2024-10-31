﻿using Microsoft.EntityFrameworkCore;
using ToDo_Api.Models;

namespace ToDoApi.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}


