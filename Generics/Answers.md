### Step2: 
#### what is the same between the two stores, and what is different?
- There is no difference between the two classes, they are doing the same thing, so I would have to create a one generic class insted of them.

### Step3:
> 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)

#### Why didn't the code compile?
- becasue the compiler doesn't sure if the T will passed to Store, have an Id, so we must make a contract that force every consumer to implement it, I use an iterface with Id prop and each consumer have to implement it to be able use Store<T>.

### Step7:
> The type 'string' cannot be used as type parameter 'T' in the generic type or method 'Store<T>'. There is no implicit reference conversion from 'string' to 'src.IHasId'.

- String class doesn't implement IHasId so we can't pass it as T to Store class.

- The common name for Store<T> is Repositroy<T>, we will learning it in Repository pattern & uint of work.


