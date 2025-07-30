Simple Inssurance Policy management

Navigate InsuranceAssesment build and run the application.

Go to root(Inssurance.Tests) and open cmd to run dotnet test.
      you will recive -> Test summary: total: 1, failed: 0, succeeded: 1, skipped: 0, duration: 2.8s

1.	Problem Statement

     Managing a person plicy details.
  	
3.	Design Considerations

    3-layer architecture.
  	DTOs
  	Dependency Injection
  	Repository Pattern

   Test coverage was focused on business logic, not API-level tests
   In-Memory DB used to simplify the setup and focus on logic.
  	
4.	Technical Features Implemented

       Dependency Injection
  	  Unit Testing
  	  Error Handling & Logging
  	  Async Operations
  
5.	Known Limitations and Future Scope

      Only GET endpoint is implemented (GET /api/policies).
  	  No client-side validation, input validation, or POST/PUT methods.
  	  Basic unit testing is done only for a single service; controller & integration tests not included.
