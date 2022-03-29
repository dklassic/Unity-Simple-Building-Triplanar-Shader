# Unity Simple Building Triplanar Shader
 A Unity project with a one-size-fits-all triplanar building shader.
 Interior mapping part using [GameDevGuide's Tutorial](https://www.youtube.com/watch?v=dUjNoIxQXAA).
 
## Requirements
The shader is only validated on Unity 2020 LTS. I've recently discovered Unity 2021 will resolve the shader improperly and I don't really have a quick fix.
I'll probably revisit this shader in the future maybe remake with actual shader code instead *sigh*

## Note
 The implementation is pretty quick and dirty so don't expect anything groundbreaking here, but if you need something that just works out of the box or just serves as a background, this shader should be pretty useful to you. Also I lack the actual knowledge to code shader, so this is generated with Shader Graph.
 You might want to remove the interior cubemap node if it doesn't fits your style though.
 No actual HDRP feautre is used so you should be able to adapt the shader graph to URP easily.
 
## Sample Images
![Day](https://imgur.com/iUyqNi5.jpg)
![Dawn](https://imgur.com/k8qh7dX.jpg)
![Night](https://imgur.com/uLmufX6.jpg)
The Skybox above was made using this amazing tutorial by [Jannik Boysen](https://medium.com/@jannik_boysen/procedural-skybox-shader-137f6b0cb77c).
