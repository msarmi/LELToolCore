/// &lt;binding BeforeBuild='inject:index' />
//"use strict";

//var gulp = require("gulp"),
//    series = require('stream-series'),
//    inject = require('gulp-inject'),
//    wiredep = require('wiredep').stream;

////var webroot = "./wwwroot/";
//var webroot = "./";

//var paths = {
//	ngModule: webroot + "Scripts/**/*.module.js",
//	ngRoute: webroot + "Scripts/**/*.route.js",
//	ngController: webroot + "Scripts/**/*.controller.js",
//	script: webroot + "Scripts/**/*.js",
//	style: webroot + "/wwwroot/css/**/*.css"
//};

//gulp.task('inject:index', function () {
//	var moduleSrc = gulp.src(paths.ngModule, { read: false });
//	var routeSrc = gulp.src(paths.ngRoute, { read: false });
//	var controllerSrc = gulp.src(paths.ngController, { read: false });
//	var scriptSrc = gulp.src(paths.script, { read: false });
//	var styleSrc = gulp.src(paths.style, { read: false });

//	gulp.src(webroot + 'Views/Home/index.cshtml')
//        .pipe(wiredep({
//        	optional: 'configuration',
//        	goes: 'here',
//        	ignorePath: '..'
//        }))
//        .pipe(inject(series(scriptSrc, moduleSrc, routeSrc, controllerSrc), { ignorePath: '/wwwroot' }))
//        .pipe(inject(series(styleSrc), { ignorePath: '/wwwroot' }))
//        .pipe(gulp.dest(webroot + 'app'));
//});