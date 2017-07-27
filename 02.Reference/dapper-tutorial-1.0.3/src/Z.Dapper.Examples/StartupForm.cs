// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Windows.Forms;
using Z.Dapper.Examples.API.Dapper.Parameter;
using Z.Dapper.Examples.API.Dapper.Result;
using Z.Dapper.Examples.API.Dapper.Utilities;
using Z.Dapper.Examples.API.DapperContrib.DataAnnotations;
using Z.Dapper.Examples.API.DapperContrib.Methods;
using Z.Dapper.Examples.API.DapperPlus.Methods;
using Anonymous = Z.Dapper.Examples.API.Dapper.Parameter.Anonymous;
using String = Z.Dapper.Examples.API.Dapper.Parameter.String;

namespace Z.Dapper.Examples.API.Dapper.Methods
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        public void ShowExample_Click(object sender, EventArgs e)
        {
            Form form = null;

            switch (((Button) sender).Name)
            {
                // Dapper - API | Query
                case "uiExecute":
                    form = new Execute();
                    break;
                case "uiQuery":
                    form = new Query();
                    break;
                case "uiQueryFirst":
                    form = new QueryFirst();
                    break;
                case "uiQueryFirstOrDefault":
                    form = new QueryFirstOrDefault();
                    break;
                case "uiQuerySingle":
                    form = new QuerySingle();
                    break;
                case "uiQuerySingleOrDefault":
                    form = new QuerySingleOrDefault();
                    break;
                case "uiQueryMultiple":
                    form = new QueryMultiple();
                    break;

                // Dapper - API | Parameter
                case "uiParameter_Anonymous":
                    form = new Anonymous();
                    break;
                case "uiParameter_Dynamic":
                    form = new Dynamic();
                    break;
                case "uiParameter_List":
                    form = new List();
                    break;
                case "uiParameter_String":
                    form = new String();
                    break;

                // Dapper - API | Result Type
                case "uiResult_Anonymous":
                    form = new Result.Anonymous();
                    break;
                case "uiResult_Strongly_Typed":
                    form = new Strongly_Typed();
                    break;
                case "uiResult_Multi_Mapping":
                    form = new Multi_Mapping();
                    break;
                case "uiResult_Multi_Result":
                    form = new Multi_Result();
                    break;
                case "uiResult_Multi_Type":
                    form = new Multi_Type();
                    break;

                // Dapper - API | Utilities
                case "uiAsync":
                    form = new Async();
                    break;
                case "uiBuffered":
                    form = new Buffered();
                    break;
                case "uiTransaction":
                    form = new Transaction();
                    break;
                case "uiStored_Procedure":
                    form = new Stored_Procedure();
                    break;

                // Dapper Plus - API | Methods
                case "uiBulk_Insert":
                    form = new Bulk_Insert();
                    break;
                case "uiBulk_Update":
                    form = new Bulk_Update();
                    break;
                case "uiBulk_Delete":
                    form = new Bulk_Delete();
                    break;
                case "uiBulk_Merge":
                    form = new Bulk_Merge();
                    break;

                // Dapper Contrib - API | Methods
                case "uiGet":
                    form = new Get();
                    break;
                case "uiGetAll":
                    form = new GetAll();
                    break;
                case "uiInsert":
                    form = new Insert();
                    break;
                case "uiUpdate":
                    form = new Update();
                    break;
                case "uiDelete":
                    form = new Delete();
                    break;
                case "uiDeleteAll":
                    form = new DeleteAll();
                    break;

                // Dapper Contrib - API | Data Annotations
                case "uiData_Annotation_Key":
                    form = new Key();
                    break;
                case "uiData_Annotation_ExplicitKey":
                    form = new ExplicitKey();
                    break;
                case "uiData_Annotation_Table":
                    form = new Table();
                    break;
                case "uiData_Annotation_Write":
                    form = new Write();
                    break;
                case "uiData_Annotation_Computed":
                    form = new Computed();
                    break;

                // Performance Comparison
                case "uiDapper_vs_EF_Query":
                    form = new Performance_Comparison.Dapper_vs_EF6.Query();
                    break;
                case "uiDapper_vs_EF_Insert":
                    form = new Performance_Comparison.Dapper_vs_EF6.Insert();
                    break;
                case "uiDapper_vs_EF_Update":
                    form = new Performance_Comparison.Dapper_vs_EF6.Update();
                    break;
                case "uiDapper_vs_EF_Delete":
                    form = new Performance_Comparison.Dapper_vs_EF6.Delete();
                    break;

                default:
                    throw new Exception("Invalid Button Name");
            }

            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}