/**
 * 
 */

	var camera, scene, renderer;
	var geometry, material, mesh;
	var touchX, touchY;
	var lon = 90;
	var phi = lat = theta = 0;
	var target = new THREE.Vector3();
	function viewPicture(picture){
		this.target = target;
		this.lon = lon;
		this.lat = lat;
		this.phi = phi;
		this.theta = theta;
		this.picture = picture;
	}
	
	viewPicture.prototype.init=function()
	{
			var that = this;
			camera = new THREE.PerspectiveCamera( 75, window.innerWidth / window.innerHeight, 1, 1000 );

			scene = new THREE.Scene();

			var sides = [
				{
					url: './Bridge2/'+ this.picture.left,
					position: [ -512, 0, 0 ],
					rotation: [ 0, Math.PI / 2, 0 ]
				},
				{
					url: './Bridge2/'+ this.picture.right,
					position: [ 512, 0, 0 ],
					rotation: [ 0, -Math.PI / 2, 0 ]
				},
				{
					url: './Bridge2/'+ this.picture.up, 
					position: [ 0,  512, 0 ],
					rotation: [ Math.PI / 2, 0, Math.PI ]
				},
				{
					url: './Bridge2/'+ this.picture.down,
					position: [ 0, -512, 0 ],
					rotation: [ - Math.PI / 2, 0, Math.PI ]
				},
				{
					url: './Bridge2/'+ this.picture.front,
					position: [ 0, 0,  512 ],
					rotation: [ 0, Math.PI, 0 ]
				},
				{
					url: './Bridge2/'+ this.picture.behind,
					position: [ 0, 0, -512 ],
					rotation: [ 0, 0, 0 ]
				}
			];

			for ( var i = 0; i < sides.length; i ++ ) {

				var side = sides[ i ];

				var element = document.createElement( 'img' );
				element.width = 1026; // 2 pixels extra to close the gap.
				element.src = side.url;

				var object = new THREE.CSS3DObject( element );
				object.position.fromArray( side.position );
				object.rotation.fromArray( side.rotation );
				scene.add( object );

			}

			renderer = new THREE.CSS3DRenderer();
			renderer.setSize( window.innerWidth, window.innerHeight );
			document.body.appendChild( renderer.domElement );

			//

			document.addEventListener( 'mousedown', onDocumentMouseDown, false );
			document.addEventListener( 'wheel', onDocumentMouseWheel, false );

			document.addEventListener( 'touchstart', onDocumentTouchStart, false );
			document.addEventListener( 'touchmove', onDocumentTouchMove, false );

			window.addEventListener( 'resize', onWindowResize, false );
			
			function onWindowResize() {

				camera.aspect = window.innerWidth / window.innerHeight;
				camera.updateProjectionMatrix();

				renderer.setSize( window.innerWidth, window.innerHeight );

			}

			function onDocumentMouseDown( event ) {
				event.preventDefault();

				document.addEventListener( 'mousemove', onDocumentMouseMove, false );
				document.addEventListener( 'mouseup', onDocumentMouseUp, false );

			}

			function onDocumentMouseMove( event ) 
			{
				var movementX = event.movementX || event.mozMovementX || event.webkitMovementX || 0;
				var movementY = event.movementY || event.mozMovementY || event.webkitMovementY || 0;
				
				that.lon -= movementX * 0.1;
				that.lat += movementY * 0.1;
				//console.log(that.lon,that.lat)
			}

			function onDocumentMouseUp( event ) {

				document.removeEventListener( 'mousemove', onDocumentMouseMove );
				document.removeEventListener( 'mouseup', onDocumentMouseUp );

			}

			function onDocumentMouseWheel( event ) {

				var fov = camera.fov + event.deltaY * 0.05;
				camera.fov = THREE.Math.clamp( fov, 10, 75 );

				camera.updateProjectionMatrix();

			}

			function onDocumentTouchStart( event ) {

				event.preventDefault();
				
				var touch = event.touches[ 0 ];
				
				touchX = touch.screenX;
				touchY = touch.screenY;

			}

			function onDocumentTouchMove( event ) {

				event.preventDefault();

				var touch = event.touches[ 0 ];
				that.lon -= ( touch.screenX - touchX ) * 0.1;
				that.lat += ( touch.screenY - touchY ) * 0.1;

				touchX = touch.screenX;
				touchY = touch.screenY;

			}

	};
			
	viewPicture.prototype.animate=function(){
		this.lon +=  0.1;
		this.lat = Math.max( - 85, Math.min( 85, this.lat ) );
		this.phi = THREE.Math.degToRad( 90 - this.lat );
		this.theta = THREE.Math.degToRad( this.lon );
		//console.log(this.lat,this.phi,this.theta)
		this.target.x = Math.sin( this.phi ) * Math.cos( this.theta );
		this.target.y = Math.cos( this.phi );
		this.target.z = Math.sin( this.phi ) * Math.sin( this.theta );
		camera.lookAt( this.target );
		renderer.render( scene, camera );
		requestAnimationFrame(this.animate.bind(this));
	}
		

	



	


	