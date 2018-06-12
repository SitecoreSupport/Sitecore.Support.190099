namespace Sitecore.Support.WFFM.Analytics.Aggregation.Processors.FormFieldValues
{
  using System;
  using Sitecore.Analytics.Aggregation.Data.Model;
  public class FormFieldValuesValue :DictionaryValue
  {
    public FormFieldValuesValue(Guid fieldId, string fieldName, string fieldValue)
    {
      FieldId = fieldId;
      FieldValue = fieldValue;
      FieldName = fieldName;
    }

    public Guid FieldId { get; private set; }

    public string FieldName { get; private set; }

    public string FieldValue { get; private set; }
  }
}