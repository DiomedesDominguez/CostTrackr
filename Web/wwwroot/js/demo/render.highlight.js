/*
Template Name: Color Admin - Responsive Admin Dashboard Template build with Twitter Bootstrap 5
Version: 5.3.1
Author: Sean Ngu
Website: http://www.seantheme.com/color-admin/
*/

var handleRenderHighlight = function() { 
	$('.hljs-wrapper pre code').each(function(i, block) {
		var dataUrl = $(this).attr('data-url');
		if (dataUrl) {
			$.ajax({
				url: dataUrl,
				dataType: 'html',
				success: function(data) {
					if (data) {
						$(block).html(data);
					}
					hljs.highlightElement(block);
				},
				error: function(data) {
					hljs.highlightElement(block);
				}
			});
		} else {
			hljs.highlightElement(block);
		}
	});
};

var Highlight = function () {
	"use strict";
	return {
		//main function
		init: function () {
			handleRenderHighlight();
		}
	};
}();

$(document).ready(function() {
	Highlight.init();
});