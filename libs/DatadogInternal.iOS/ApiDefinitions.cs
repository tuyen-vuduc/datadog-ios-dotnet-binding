using DatadogInternal;
using Foundation;
using ObjCRuntime;
using System;

namespace DatadogInternal
{
	// @interface DatadogURLSessionDelegate : NSObject <NSURLSessionDataDelegate>
	[BaseType (typeof(NSObject), Name = "_TtC15DatadogInternal25DatadogURLSessionDelegate")]
	partial interface DatadogURLSessionDelegate : INSUrlSessionDataDelegate
	{
		// -(instancetype _Nonnull)initWithAdditionalFirstPartyHosts:(NSSet<NSString *> * _Nonnull)additionalFirstPartyHosts;
		[Export ("initWithAdditionalFirstPartyHosts:")]
		IntPtr Constructor (NSSet<NSString> additionalFirstPartyHosts);

		// -(void)URLSession:(NSURLSession * _Nonnull)session task:(NSURLSessionTask * _Nonnull)task didFinishCollectingMetrics:(NSURLSessionTaskMetrics * _Nonnull)metrics;
		[Export ("URLSession:task:didFinishCollectingMetrics:")]
		void URLSession (NSUrlSession session, NSUrlSessionTask task, NSUrlSessionTaskMetrics metrics);

		// -(void)URLSession:(NSURLSession * _Nonnull)session dataTask:(NSURLSessionDataTask * _Nonnull)dataTask didReceiveData:(NSData * _Nonnull)data;
		[Export ("URLSession:dataTask:didReceiveData:")]
		void URLSession (NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data);

		// -(void)URLSession:(NSURLSession * _Nonnull)session task:(NSURLSessionTask * _Nonnull)task didCompleteWithError:(NSError * _Nullable)error;
		[Export ("URLSession:task:didCompleteWithError:")]
		void URLSession (NSUrlSession session, NSUrlSessionTask task, [NullAllowed] NSError error);
	}

	// @protocol __URLSessionDelegateProviding <NSURLSessionDelegate>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface I__URLSessionDelegateProviding {}

	[Model, Protocol (Name = "_TtP15DatadogInternal29__URLSessionDelegateProviding_")]
	[BaseType(typeof(NSObject))]
	interface __URLSessionDelegateProviding : INSUrlSessionDelegate
	{
		[Wrap ("WeakDdURLSessionDelegate"), Abstract]
		DatadogURLSessionDelegate DdURLSessionDelegate { get; }

		// @required @property (readonly, nonatomic, strong) DatadogURLSessionDelegate * _Nonnull ddURLSessionDelegate;
		[Abstract]
		[NullAllowed, Export ("ddURLSessionDelegate", ArgumentSemantic.Strong)]
		NSObject WeakDdURLSessionDelegate { get; }
	}

	// @interface DatadogInternal_Swift_681 (DatadogURLSessionDelegate) <__URLSessionDelegateProviding>
	// [Category]
	// [BaseType (typeof(DatadogURLSessionDelegate))]
	partial interface DatadogURLSessionDelegate : __URLSessionDelegateProviding
	{
		// [Wrap ("WeakDdURLSessionDelegate")]
		// DatadogURLSessionDelegate DdURLSessionDelegate();

		// // @property (readonly, nonatomic, strong) DatadogURLSessionDelegate * _Nonnull ddURLSessionDelegate;
		// [NullAllowed, Export ("ddURLSessionDelegate", ArgumentSemantic.Strong)]
		// NSObject WeakDdURLSessionDelegate ();
	}
}
