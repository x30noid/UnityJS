mergeInto(LibraryManager.library, {

  // Create a new function with the same name as
  // the event listeners name and make sure the
  // parameters match as well.

  SceneLoaded: function(utf8String) {

    // Within the function we're going to trigger
    // the event within the ReactUnityWebGL object
    // which is exposed by the library to the window.

    var SceneString = UTF8ToString(utf8String);
    SceneFinishedLoading(SceneString);
  }
});