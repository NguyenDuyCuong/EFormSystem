// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using Dapper.Contrib.Extensions;

namespace Z.Dapper.Examples.API.Dapper.Methods
{
    [Table("InvoiceDetail")]
    public class InvoiceDetailContrib
    {
        [ExplicitKey]
        public int InvoiceID { get; set; }

        public string Detail { get; set; }
    }
}