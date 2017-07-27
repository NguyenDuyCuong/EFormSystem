// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using Dapper.Contrib.Extensions;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples
{
    [Table("Invoice")]
    public class InvoiceContrib
    {
        [Key]
        public int InvoiceID { get; set; }

        public string Code { get; set; }
        public InvoiceKind Kind { get; set; }

        [Write(false)]
        [Computed]
        public string FakeProperty { get; set; }
    }
}