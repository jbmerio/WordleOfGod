window.openReading = () => {
	document.getElementById("reading-panel").animate([
		{ height: '0px' },
		{ height: 'calc(calc(100vh - 555px) - 160px)' },
		{ height: 'calc(calc(100vh - 555px) - 80px)' },
		{ height: 'calc(calc(100vh - 555px) - 40px)' },
		{ height: 'calc(calc(100vh - 555px) - 20px)' },
		{ height: 'calc(calc(100vh - 555px) - 10px)' },
		{ height: 'calc(calc(100vh - 555px) - 5px)' },
		{ height: 'calc(100vh - 555px)' },
	], {
		duration: 1000
	});
	document.getElementById("reading-panel").style.height = 'calc(100vh - 555px)';
}

window.openMenu = () => {
	document.getElementById("menu").animate([
		{ transform: 'translateY(-55px)' },
		{ transform: 'translateY(0px)' },
	], {
		duration: 200
	});
}