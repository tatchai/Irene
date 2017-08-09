# Irene

...

## Instruction

To create a new entity.

### MODELs: Create a new entity class in Models (POCO please!)
  * Inherits from EntityBase<T>. T should be int, Guid, or string.
  * Implements IDataError for Windows Form UI (place your code here) 
  * Implements IValidatableObject for EF
  * Implements INotifyPropertyChanged (see class Car)

### DATA: Update AppDb
* Add new entity classes in AppDb (DbContext)

### DATA: Add new Repository class 
Inherits from RepositoryBase<YourEntity>)
```
  public class RoleRepository : RepositoryBase<Role> {

    public RoleRepository() { }

    public RoleRepository(DbContext context) : base(context) {
      //
    }

  }
```

### DATA: Update class UnitOfWork
Update 3 places.

### SERVICEs: Add Service class 
```
  public class RoleService : ServiceBase<Role, int> {
    public RoleService(UnitOfWork uow) : base(uow) {
      //
    } 
  }
```
### SERVICEs: Update class App
Update 4 places.

