using System;

namespace API.Repositories;

public class AccountMockRepo
{
    List<Models.Account> accounts = [
        new(){CreatedDate = DateTime.Now,AccountNumber="111-222222",AccountType="Basic", Balance=0.00M,IsBlocked=false,Owner="Michael Gustavsson"},
        new(){CreatedDate = DateTime.Now,AccountNumber="111-333333",AccountType="Savings", Balance=5000.00M,IsBlocked=false,Owner="Michael Gustavsson"}
    ];
}
