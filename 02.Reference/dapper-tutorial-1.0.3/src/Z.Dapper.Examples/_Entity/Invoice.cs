// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System.Collections.Generic;

namespace Z.Dapper.Examples.API.Dapper.Methods
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string Code { get; set; }
        public InvoiceKind Kind { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public InvoiceDetail Detail { get; set; }
    }
}