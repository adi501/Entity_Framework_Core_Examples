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

**Table Attribute with Schema Example**
```
 [Table("TableName",Schema ="User")]
 public class Table_Attribute_With_Schema_Exp
 {
         public int Id { get; set; }
         public string Name { get; set; }
 }
```
```
 //in Context class :Table Attribute with Schema Example
 public DbSet<Table_Attribute_With_Schema_Exp> table_Attribute_With_Schema_Exps { get; set; }
```
```
 //Add-Migration "Table Attribute with Schema Example"
 //Update-Database
```
![image](https://github.com/user-attachments/assets/5994ae4f-fbe3-4e28-9b80-4a809174292f)
