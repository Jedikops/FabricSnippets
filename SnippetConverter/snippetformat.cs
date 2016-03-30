using System;
using System.Xml;
using System.Xml.Serialization;

[Serializable]
[XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet")]
[XmlRoot(Namespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet", IsNullable = false)]
public partial class CodeSnippet
{

	private CodeSnippetHeader headerField;

	private CodeSnippetSnippet snippetField;

	private string formatField;

	/// <remarks/>
	[XmlElement("Header")]
	public CodeSnippetHeader Header
	{
		get
		{
			return this.headerField;
		}
		set
		{
			this.headerField = value;
		}
	}

	[XmlElement("Snippet")]
	public CodeSnippetSnippet Snippet
	{
		get
		{
			return this.snippetField;
		}
		set
		{
			this.snippetField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string Format
	{
		get
		{
			return "1.0.0";
		}
		set
		{
			this.formatField = value;
		}
	}
}

[Serializable]
[XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet")]
public partial class CodeSnippetHeader
{

	private string titleField;

	private string authorField;

	private string descriptionField;

	private string shortcutField;

	private CodeSnippetHeaderSnippetTypes[] snippetTypesField;

	public string Title
	{
		get
		{
			return this.titleField;
		}
		set
		{
			this.titleField = value;
		}
	}

	public string Author
	{
		get
		{
			return this.authorField;
		}
		set
		{
			this.authorField = value;
		}
	}

	public string Description
	{
		get
		{
			return this.descriptionField;
		}
		set
		{
			this.descriptionField = value;
		}
	}

	public string Shortcut
	{
		get
		{
			return this.shortcutField;
		}
		set
		{
			this.shortcutField = value;
		}
	}

	[XmlElement("SnippetTypes")]
	public CodeSnippetHeaderSnippetTypes[] SnippetTypes
	{
		get
		{
			return this.snippetTypesField;
		}
		set
		{
			this.snippetTypesField = value;
		}
	}
}

[Serializable]
[XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet")]
public partial class CodeSnippetHeaderSnippetTypes
{

	private string snippetTypeField;

	public string SnippetType
	{
		get
		{
			return this.snippetTypeField;
		}
		set
		{
			this.snippetTypeField = value;
		}
	}
}

[Serializable]
[XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet")]
public class CodeSnippetSnippet
{
	private CodeSnippetSnippetCode snippetCodeField;

	[XmlElement("Code")]
	public CodeSnippetSnippetCode SnippetCode
	{
		get
		{
			return this.snippetCodeField;
		}
		set
		{
			this.snippetCodeField = value;
		}
	}
}

[Serializable]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet")]
public partial class CodeSnippetSnippetCode
{

	private string languageField;

	private string valueField;

	[XmlAttribute]
	public string Language
	{
		get
		{
			return this.languageField;
		}
		set
		{
			this.languageField = value;
		}
	}

	[XmlIgnore]
	public string Code
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}

	//[XmlText]
	public XmlCDataSection Value
	{
		get
		{
			return new XmlDocument().CreateCDataSection(this.valueField);
		}
		set
		{
			this.valueField = value.Value;
		}
	}
}

