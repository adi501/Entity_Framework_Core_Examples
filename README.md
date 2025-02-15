**Table Attribute Example**
```
  [Table("CustomerMaster")]
 public class Customer
 {
     public int Id { get; set; }
     public string Name { get; set; }
 }
----------------------------------------------

//Add this in Context class for
public DbSet<Customer> Customer { get; set; }
```
```
 //Add-Migration "Table Attribute Example"
 //Update-Database
```

![image](https://github.com/user-attachments/assets/1a6c43ad-52b9-40a7-b6f7-5de87cd85cc7)
