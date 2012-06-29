using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace GCMSharp.Client
{
	[BroadcastReceiver(Permission=GCMConstants.PERMISSION_GCM_INTENTS)]
	[IntentFilter(new string[] { GCMConstants.INTENT_FROM_GCM_MESSAGE })]
	[IntentFilter(new string[] { GCMConstants.INTENT_FROM_GCM_REGISTRATION_CALLBACK })]
	[IntentFilter(new string[] { GCMConstants.INTENT_FROM_GCM_LIBRARY_RETRY })]
	public class GCMBroadcastReceiver : BroadcastReceiver
	{
		const string TAG = "GCMBroadcastReceiver";

		public override void OnReceive(Context context, Intent intent)
		{
			Log.Verbose(TAG, "OnReceive: " + intent.Action);
			var className = context.PackageName + GCMConstants.DEFAULT_INTENT_SERVICE_CLASS_NAME;

			Log.Verbose(TAG, "GCM IntentService Class: " + className);

			GCMBaseIntentService.RunIntentInService(context, intent, className);
			SetResult(Result.Ok, null, null);
		}
	}
}