namespace BizTalkEjemploESB
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class ItineraryRCV : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>Microsoft.Practices.ESB.Itinerary.PipelineComponents.ItineraryS"+
"elector,Microsoft.Practices.ESB.Itinerary.PipelineComponents, Version=2.1.0.0, Culture=neutral, Publ"+
"icKeyToken=31bf3856ad364e35</Name>          <ComponentName>ESB Itinerary Selector</ComponentName>   "+
"       <Description>Selects itinerary via any resolver. Set up resolver connection string to specify"+
" itinerary resolution method.</Description>          <Version>2.1</Version>          <Properties>   "+
"         <Property Name=\"ResolverConnectionString\">              <Value xsi:type=\"xsd:string\">ITINER"+
"ARY:\\\\name=SimpleTransformAndRoute</Value>            </Property>            <Property Name=\"Itinera"+
"ryFactKey\">              <Value xsi:type=\"xsd:string\">Reolver.Itinerary</Value>            </Propert"+
"y>            <Property Name=\"IgnoreErrorKey\">              <Value xsi:type=\"xsd:boolean\">false</Val"+
"ue>            </Property>            <Property Name=\"ValidateItinerary\">              <Value xsi:ty"+
"pe=\"xsd:boolean\">false</Value>            </Property>          </Properties>          <CachedDisplay"+
"Name>ESB Itinerary Selector</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>    "+
"    </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\""+
" _locID=\"2\" Name=\"Disassemble\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e410"+
"5-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>    <Stage>      <PolicyFileStage _"+
"locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId="+
"\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components>        <Component>          <Name>Micros"+
"oft.Practices.ESB.PipelineComponents.Dispatcher,Microsoft.Practices.ESB.PipelineComponents, Version="+
"2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <ComponentName>ESB Dispatc"+
"her</ComponentName>          <Description>BizTalk ESB Dispatcher Processes Itinerary, Routing and Tr"+
"ansform  Requests</Description>          <Version>2.1</Version>          <Properties>            <Pr"+
"operty Name=\"Enabled\">              <Value xsi:type=\"xsd:boolean\">true</Value>            </Property"+
">            <Property Name=\"Endpoint\">              <Value xsi:type=\"xsd:string\" />            </Pr"+
"operty>            <Property Name=\"MapName\">              <Value xsi:type=\"xsd:string\" />           "+
" </Property>            <Property Name=\"Validate\">              <Value xsi:type=\"xsd:boolean\">true</"+
"Value>            </Property>            <Property Name=\"RoutingServiceName\">              <Value xs"+
"i:type=\"xsd:string\">Microsoft.Practices.ESB.Services.Routing</Value>            </Property>         "+
"   <Property Name=\"TransformServiceName\">              <Value xsi:type=\"xsd:string\">Microsoft.Practi"+
"ces.ESB.Services.Transform</Value>            </Property>          </Properties>          <CachedDis"+
"playName>ESB Dispatcher</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        "+
"</Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _lo"+
"cID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-453"+
"6-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "93d620c3-6be3-48cd-803d-05840d78e40d";
        
        public ItineraryRCV()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.Practices.ESB.Itinerary.PipelineComponents.ItinerarySelector,Microsoft.Practices.ESB.Itinerary.PipelineComponents, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"ResolverConnect"+
"ionString\">      <Value xsi:type=\"xsd:string\">ITINERARY:\\\\name=SimpleTransformAndRoute</Value>    </"+
"Property>    <Property Name=\"ItineraryFactKey\">      <Value xsi:type=\"xsd:string\">Reolver.Itinerary<"+
"/Value>    </Property>    <Property Name=\"IgnoreErrorKey\">      <Value xsi:type=\"xsd:boolean\">false<"+
"/Value>    </Property>    <Property Name=\"ValidateItinerary\">      <Value xsi:type=\"xsd:boolean\">fal"+
"se</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.Practices.ESB.PipelineComponents.Dispatcher,Microsoft.Practices.ESB.PipelineComponents, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"Enabled\">      "+
"<Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"Endpoint\">      <Value "+
"xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"MapName\">      <Value xsi:type=\"xsd:strin"+
"g\" />    </Property>    <Property Name=\"Validate\">      <Value xsi:type=\"xsd:boolean\">true</Value>  "+
"  </Property>    <Property Name=\"RoutingServiceName\">      <Value xsi:type=\"xsd:string\">Microsoft.Pr"+
"actices.ESB.Services.Routing</Value>    </Property>    <Property Name=\"TransformServiceName\">      <"+
"Value xsi:type=\"xsd:string\">Microsoft.Practices.ESB.Services.Transform</Value>    </Property>  </Pro"+
"perties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
