/**
 * 
 */
			function Terrain()
			{
				this.stats = null;
				this.container = null;
				this.camera = null;
				this.scene = null;
				this.renderer = null;
				this.mesh = null;
				this.mouseX = 0;
				this.mouseY = 0;
				this.windowHalfX = window.innerWidth / 2;
				this.windowHalfY = window.innerHeight / 2;
				this.trackballControls = null;
				this.clock = null;
			}
			
			
			Terrain.prototype.init = function()
			{
				var that = this;
				this.clock = new THREE.Clock();
				
				this.stats = new Stats();
				this.container = document.getElementById( 'container' );

				this.camera = new THREE.PerspectiveCamera( 60, window.innerWidth / window.innerHeight, 1, 10000 );
				this.camera.position.z = 700;
				this.camera.position.y = 500;
				this.trackballControls = new THREE.TrackballControls(this.camera);

				this.trackballControls.rotateSpeed = 1.0;
				this.trackballControls.zoomSpeed = 1.0;
				this.trackballControls.panSpeed = 1.0;
				this.trackballControls.staticMoving = true;
				
				this.scene = new THREE.Scene();
				this.scene.background = new THREE.Color( 0xbfd1e5 );

				var data = this.generateHeight( 1024, 1024 );
				var texture = new THREE.CanvasTexture( this.generateTexture( data, 1024, 1024 ) );
				var material = new THREE.MeshBasicMaterial( { map: texture, overdraw: 0.5 , side:THREE.Double } );

				var quality = 32, step = 1024 / quality;

				var geometry = new THREE.PlaneGeometry( 3000, 3000, quality - 1, quality - 1 );
				geometry.rotateX( - Math.PI / 3 );
				//console.log(geometry.vertices.length)
				for ( var i = 0, l = geometry.vertices.length; i < l; i ++ ) {
					var x = i % quality, y = Math.floor( i / quality );
					geometry.vertices[ i ].y = data[ ( x * step ) + ( y * step ) * 1024 ] * 2 - 128;
					
				}
				console.log(geometry)
				this.mesh = new THREE.Mesh( geometry, material );
				this.scene.add( this.mesh );

				this.renderer = new THREE.CanvasRenderer();
				this.renderer.setPixelRatio( window.devicePixelRatio );
				this.renderer.setSize( window.innerWidth, window.innerHeight );

				this.container.innerHTML = "";

				this.container.appendChild( this.renderer.domElement );

				
				this.container.appendChild( this.stats.dom );

				document.addEventListener( 'mousemove', that.onDocumentMouseMove.bind(that), false );

				window.addEventListener( 'resize', that.onWindowResize.bind(that), false );

			}
			
			Terrain.prototype.onDocumentMouseMove = function(event)
			{
				this.mouseX = event.clientX - this.windowHalfX;
				this.mouseY = event.clientY - this.windowHalfY;				
			}
			
			Terrain.prototype.onWindowResize = function()
			{
				this.windowHalfX = window.innerWidth / 2;
				this.windowHalfY = window.innerHeight / 2;

				this.camera.aspect = window.innerWidth / window.innerHeight;
				this.camera.updateProjectionMatrix();

				this.renderer.setSize( window.innerWidth, window.innerHeight );
			}
			
			Terrain.prototype.generateHeight = function( width, height )
			{
				var data = new Uint8Array( width * height ), perlin = new ImprovedNoise(),
				size = width * height, quality = 2, z = Math.random() * 100;
				for ( var j = 0; j < 4; j ++ ) {
					quality *= 4;
					for ( var i = 0; i < size; i ++ ) {
						var x = i % width, y = ~~ ( i / width );
						data[ i ] += Math.abs( perlin.noise( x / quality, y / quality, z ) * 0.5 ) * quality + 10;
					}
				}
				return data;
			}

			Terrain.prototype.generateTexture = function(data, width, height)
			{
				var canvas, context, image, imageData,
				level, diff, vector3, sun, shade;

				vector3 = new THREE.Vector3( 0, 0, 0 );

				sun = new THREE.Vector3( 1, 1, 1 );
				sun.normalize();

				canvas = document.createElement( 'canvas' );
				canvas.width = width;
				canvas.height = height;

				context = canvas.getContext( '2d' );
				context.fillStyle = "#000";
				context.fillRect( 0, 0, width, height );

				image = context.getImageData( 0, 0, width, height );
				imageData = image.data;

				for ( var i = 0, j = 0, l = imageData.length; i < l; i += 4, j ++  ) {

					vector3.x = data[ j - 1 ] - data[ j + 1 ];
					vector3.y = 2;
					vector3.z = data[ j - width ] - data[ j + width ];
					vector3.normalize();

					shade = vector3.dot( sun );

					imageData[ i ] = ( 96 + shade * 128 ) * ( data[ j ] * 0.007 );
					imageData[ i + 1 ] = ( 32 + shade * 96 ) * ( data[ j ] * 0.007 );
					imageData[ i + 2 ] = ( shade * 96 ) * ( data[ j ] * 0.007 );

				}

				context.putImageData( image, 0, 0 );

				return canvas;
			}




			//

			Terrain.prototype.animate = function() {
				this.trackballControls.update(this.clock.getDelta());
				this.camera.lookAt( this.scene.position );
				this.renderer.render( this.scene, this.camera );
				
				this.stats.update();
				requestAnimationFrame( this.animate.bind(this) );


			}