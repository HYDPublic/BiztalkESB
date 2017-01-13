namespace BizTalkEjemploESB {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkEjemploESB.SchemaEjemplo2", typeof(global::BizTalkEjemploESB.SchemaEjemplo2))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkEjemploESB.SchemaEjemplo2", typeof(global::BizTalkEjemploESB.SchemaEjemplo2))]
    public sealed class MapEjemplo2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://BizTalkEjemploESB.SchemaEjemplo2"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Client"" />
  </xsl:template>
  <xsl:template match=""/ns0:Client"">
    <ns0:Client>
      <Client>
        <Id>
          <xsl:value-of select=""Client/Id/text()"" />
        </Id>
        <Name>
          <xsl:value-of select=""Client/Name/text()"" />
        </Name>
        <Phone>
          <xsl:value-of select=""Client/Phone/text()"" />
        </Phone>
        <xsl:value-of select=""Client/text()"" />
      </Client>
    </ns0:Client>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkEjemploESB.SchemaEjemplo2";
        
        private const global::BizTalkEjemploESB.SchemaEjemplo2 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkEjemploESB.SchemaEjemplo2";
        
        private const global::BizTalkEjemploESB.SchemaEjemplo2 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkEjemploESB.SchemaEjemplo2";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkEjemploESB.SchemaEjemplo2";
                return _TrgSchemas;
            }
        }
    }
}
