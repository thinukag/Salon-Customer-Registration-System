ALTER Proc DetailsAdd
  
    @Id_No VARCHAR(50), 
    @Name VARCHAR(50), 
    @Treatments VARCHAR(50), 
    @Price MONEY , 
    @Date DATE
	AS
		INSERT INTO worksheet( Id_No, Name, Treatments, Price, Date )
		VALUES ( @Id_No, @Name, @Treatments, @Price, @Date )
