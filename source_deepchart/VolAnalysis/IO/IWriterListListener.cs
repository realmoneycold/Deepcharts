using System;
using System.Collections;

namespace VolAnalysis.IO;

internal interface IWriterListListener
{
	IList SelectedCollection { get; set; }

	void SetApplyDelegate(Action last);

	void SetElementInit(Func<Type, object> v);
}
