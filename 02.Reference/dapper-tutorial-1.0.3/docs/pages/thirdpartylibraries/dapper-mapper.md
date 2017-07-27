---
layout: default
title: Third Party Library - Dapper.Mapper
permalink: dapper-mapper
---

{% include template-h1.html %}

## Dapper.Mapper

### Overview

Dapper.Mapper is a small library which extends Dapper multi-mapping functionality. It allows you to map a single row to multiple objects. This library automatically figures out the relationships between the returned objects and automatically assigns them.

### Installation

Dapper.Mapper is available through NuGet: <a href="https://www.nuget.org/packages/Dapper.Mapper/" target="_blank">https://www.nuget.org/packages/Dapper.Mapper/</a>

You can easily install this library by running the following command:

> PM> Install-Package Dapper.Mapper

### APIs

If you have used Dapper, then you will have an idea of writing mapping explicitly as shown below.

{% highlight csharp %}

var sql = "SELECT * FROM Invoices AS A INNER JOIN InvoiceDetails AS B ON A.InvoiceID = B.InvoiceID;";

using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var invoices = connection.Query<Invoice, InvoiceDetail, Invoice>(
            sql,
            (invoice, invoiceDetail) =>
            {
                invoice.Detail = invoiceDetail;
                return invoice;
            },
            splitOn: "InvoiceID")
        .Distinct()
        .ToList();
}

{% endhighlight %}

Instead of writing all these explicitly, Dapper.Mapper will handle the relationships between the returned objects automatically.

{% highlight csharp %}

var sql = "SELECT * FROM Invoices AS A INNER JOIN InvoiceDetails AS B ON A.InvoiceID = B.InvoiceID;";

using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var invoices = connection.Query<Invoice, InvoiceDetail>(sql);
}

{% endhighlight %}

Unfortunately, there is no proper documentation available for this library.

### Support

Currently, this library is not supported.
