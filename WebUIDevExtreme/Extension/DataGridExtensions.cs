using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;

namespace WebUIDevExtreme.Extension
{
    public static class DataGridExtensions
    {
        public static DataGridBuilder<T> AutoConfigDataGrid<T>(this DataGridBuilder<T> dataGridBuilder, string controller, string key = "Id")
        {
            dataGridBuilder.DataSource(ds => ds.Mvc()
                                .Controller(controller)
                                .LoadAction("Get")
                                .InsertAction("Insert")
                                .UpdateAction("Update")
                                .DeleteAction("Delete")
                                //.OnInserting("function(values) {  return $.ajax({url: '/api/Addresses',  dataType: 'json',  data: values, type: 'POST'  });}")
                                .OnBeforeSend("function(method, ajaxOptions) { ajaxOptions.data = JSON.stringify(ajaxOptions.data);ajaxOptions.contentType = 'application/json';}")
                                .Key(key)
                            )
                        .ID("grid")
                        //.OnRowInserting("onInsertGrid")
                        //.RepaintChangesOnly(true)
                        .FilterRow(f => f.Visible(true))
                        .HeaderFilter(f => f.Visible(true))
                        .GroupPanel(p => p.Visible(true))
                        .Scrolling(s => s.Mode(GridScrollingMode.Virtual))
                        .Height(600)
                        .ShowBorders(true)
                        .RemoteOperations(true)
                        .Paging(p => p.PageSize(10))
                        .Pager(p => p
                            .ShowPageSizeSelector(true)
                            .AllowedPageSizes(new[] { 10, 25, 50, 100 })
                        )
                        .SearchPanel(s => s
                            .Visible(true)
                            .HighlightCaseSensitive(true)
                        )
                        .Grouping(g => g.AutoExpandAll(false))
                        .Editing(e => e.Mode(DevExtreme.AspNet.Mvc.GridEditMode.Popup)
                        .AllowAdding(true)
                        .AllowUpdating(true)
                        .AllowDeleting(true)
                    );
            return dataGridBuilder;
        }
    }
}
