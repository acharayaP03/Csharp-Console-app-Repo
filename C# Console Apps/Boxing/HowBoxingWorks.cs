
    /**
     * Boxing: happens implicityly each time when we assign a value type to an instance of reference type.
     * in other words, it is a process of wrapping a value type into an intance of System.Object, which is a refrence type.
     * it is necessary, so we can ue all tyes in C# in a uniform was as object.
     * for example variousObject has all type 
     * 
     * Unboxing: is converting the boxed value back to the value type.
     * 
     * */
    //int number = 5; // value type
    //object boxedNumber = number; // reference type

    //int unboxedNumber = (int)boxedNumber; // unboxing

    //var variousObjects = new List<object>
    //{
    //    1,
    //    1.5m,
    //    new DateTime(2024,6,1),
    //    "hello",
    //    new { Name = "Anna", Age = 61 },
    //};
