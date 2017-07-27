---
layout: default
title: Third Party Library - Dapper.Plus
permalink: dapper-plus-third-party-library
---

{% include template-h1.html %}

## Dapper.Plus

### Overview

Dapper.Plus is a small library that you can add to your project which will extend your IDbConnection and IDbTransaction interfaces with high efficient Bulk operations methods.

- Bulk Insert
- Bulk Update
- Bulk Delete
- Bulk Merge

Using this library, you can perform saving operations in the **fastest way**. It can be used with or without Dapper, and it is also compatible with all others Dapper packages.

### Installation

Dapper.Plus is only available through NuGet: <a href="https://www.nuget.org/packages/Z.Dapper.Plus/" target="_blank">https://www.nuget.org/packages/Z.Dapper.Plus/</a>

You can easily install this library by running the following command:

> PM> Install-Package Z.Dapper.Plus 

### PRO Version

Every month, a FREE trial of the PRO version is available to let you evaluate all its features without limitations.

| Features | PRO |
| :---------- | :----- |
| Bulk Insert | Yes |
| Bulk Delete | Yes |
| Bulk Update | Yes |
| Bulk Merge | Yes |
| Bulk Action Async | Yes |
| Bulk Also Action | Yes |
| Bulk Then Action | Yes |
| Commercial License | Yes |
| Royalty-Free | Yes |
| Support & Upgrades (1 year) | Yes |

More information can be found at: <a href="http://dapper-plus.net/" target="_blank">http://dapper-plus.net/</a>

### APIs

Once you installed this library then the following extension methods will automatically add to DbConnection:

- BulkInsert
- BulkUpdate
- BulkDelete
- BulkMerge

There is no configuration required and no need for extra coding. You can easily use these extension methods in your code.

{% highlight csharp %}

// Bulk Insert
connection.BulkInsert(invoices)
	.ThenForEach(x => x.Items.ForEach(y => y.InvoiceID = x.InvoiceID))
	.ThenBulkInsert(x => x.Items);
  
// Bulk Update
connection.BulkUpdate(invoices, x => x.Items);

// Bulk Delete
connection.BulkDelete(invoices.SelectMany(x => x.Items))
	.BulkDelete(invoices);

// Bulk Merge
connection.BulkMerge(invoices)
	.ThenForEach(x => x.Items.ForEach(y => y.InvoiceID = x.InvoiceID))
	.ThenBulkMerge(x => x.Items);
  
{% endhighlight %}

You can find the detailed documentation here: <a href="https://github.com/zzzprojects/Dapper-Plus/wiki" target="_blank">https://github.com/zzzprojects/Dapper-Plus/wiki</a>

### DB Provider Supported

Dapper.Plus is compatible with all major database provider:

- SQL Server 2008+
- SQL Azure
- SQL Compact
- Oracle
- MySQL
- SQLite
- PostgreSQL

### Support

If you have any further queries, contact the outstanding customer support for any request, and you will get your answer within the next business day, hour, or minutes!
- info@zzzprojects.com
