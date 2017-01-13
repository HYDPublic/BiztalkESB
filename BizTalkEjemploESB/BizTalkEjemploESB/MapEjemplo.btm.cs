namespace BizTalkEjemploESB {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkEjemploESB.SchemaEjemplo", typeof(global::BizTalkEjemploESB.SchemaEjemplo))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkEjemploESB.SchemaEjemploSalida", typeof(global::BizTalkEjemploESB.SchemaEjemploSalida))]
    public sealed class MapEjemplo : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://BizTalkEjemploESB.SchemaEjemploSalida"" xmlns:s0=""http://BizTalkEjemploESB.SchemaEjemplo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Employee"" />
  </xsl:template>
  <xsl:template match=""/s0:Employee"">
    <xsl:variable name=""var:v1"" select=""count(/s0:Employee/Employee)"" />
    <ns0:Payroll>
      <NoOfEmployees>
        <xsl:value-of select=""$var:v1"" />
      </NoOfEmployees>
      <xsl:variable name=""var:v2"" select=""userCSharp:InitCumulativeSum(0)"" />
      <xsl:for-each select=""/s0:Employee/Employee"">
        <xsl:variable name=""var:v3"" select=""userCSharp:AddToCumulativeSum(0,string(Salary/text()),&quot;1000&quot;)"" />
      </xsl:for-each>
      <xsl:variable name=""var:v4"" select=""userCSharp:GetCumulativeSum(0)"" />
      <TotalAmt>
        <xsl:value-of select=""$var:v4"" />
      </TotalAmt>
    </ns0:Payroll>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkEjemploESB.SchemaEjemplo";
        
        private const global::BizTalkEjemploESB.SchemaEjemplo _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkEjemploESB.SchemaEjemploSalida";
        
        private const global::BizTalkEjemploESB.SchemaEjemploSalida _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BizTalkEjemploESB.SchemaEjemplo";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkEjemploESB.SchemaEjemploSalida";
                return _TrgSchemas;
            }
        }
    }
}
