GCM-Sharp
=========

What is it?
-----------
Google Cloud Messaging Client Library ported to C#

In the Google Android SDK extras, since the 4.1 (API 16) release, there is now an 'extra' called **Google Cloud Messaging for Android Library**.
This package exists to assist developers in implementing Google Cloud Messaging both on the client and server.  There are 2 jar files, one for the client, one for the server.

GCM-Sharp focuses on the client library, and is a direct port of the gcm-client's gcm.jar into 100% C# Mono for Android code.  I opted to port the source code that google provides for this library instead of binding the .jar file.

While this library is not required to implement Google Cloud Messaging in your Mono for Android application, it certainly makes it easier, and does some of the heavy lifting for you!


How do I send Google Cloud Messaging notifications?
---------------------------------------------------
Check out PushSharp (https://github.com/Redth/PushSharp).  It is a project designed to make sending GCM Notifications from your server very easy!


License
-------
Apache PushSharp
Copyright 2012 The Apache Software Foundation

This product includes software developed at
The Apache Software Foundation (http://www.apache.org/).


