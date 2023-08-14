using WidgetFactory;

IWidgetFactory motifFactory = new MotifWidgetFactory.MotifWidgetFactory();
var sb = motifFactory.CreateScrollBar();
sb.ScrollUp();
sb.ScrollDown();

var w = motifFactory.CreateWindows();
w.Open();
w.Close();

IWidgetFactory pmFactory = new PmWidgetFactory.PmWidgetFactory();
var pmSb = pmFactory.CreateScrollBar();
pmSb.ScrollUp();
pmSb.ScrollDown();

var pmw = pmFactory.CreateWindows();
pmw.Open();
pmw.Close();