namespace Radzen.Localizer;

public class RadzenDataGridLocalized<TItem> : RadzenDataGrid<TItem>
{

    [Inject] IStringLocalizer<SharedResources> L { get; set; }

    protected override void OnInitialized()
    {
        AllColumnsText = L["AllColumnsText"];
        AndOperatorText = L["AndOperatorText"];
        ApplyFilterText = L["ApplyFilterText"];
        ClearFilterText = L["ClearFilterText"];
        ColumnsShowingText = L["ColumnsShowingText"];
        ColumnsText = L["ColumnsText"];
        ContainsText = L["ContainsText"];
        DoesNotContainText = L["DoesNotContainText"];
        EnumFilterSelectText = L["DoesNotContainText"];
        EndsWithText = L["EndsWithText"];
        EqualsText = L["EqualsText"];
        FilterText = L["FilterText"];
        GreaterThanOrEqualsText = L["GreaterThanOrEqualsText"];
        GreaterThanText = L["GreaterThanText"];
        IsEmptyText = L["IsEmptyText"];
        IsNotEmptyText = L["IsNotEmptyText"];
        IsNotNullText = L["IsNotNullText"];
        IsNullText = L["IsNullText"];
        LessThanOrEqualsText = L["LessThanOrEqualsText"];
        LessThanText = L["LessThanText"];
        NotEqualsText = L["NotEqualsText"];
        OrOperatorText = L["OrOperatorText"];
        StartsWithText = L["StartsWithText"];
        base.OnInitialized();
    }
}
