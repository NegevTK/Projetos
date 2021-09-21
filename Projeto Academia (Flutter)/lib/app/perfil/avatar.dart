import 'package:flutter/material.dart';

class Avatar extends StatelessWidget {
  final String avatarUrl;
  final Function onTap;

  const Avatar({this.avatarUrl, this.onTap});

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: onTap,
      child: Center(
        child: avatarUrl == null
            ? CircleAvatar(
                backgroundColor: Colors.white,
                radius: 80.0,
                child: Icon(
                  Icons.photo_camera,
                  color: Colors.grey[600],
                  size: 80.0,
                ),
              )
            : CircleAvatar(
                backgroundColor: Colors.white,
                radius: 80.0,
                backgroundImage: NetworkImage(avatarUrl),
              ),
      ),
    );
  }
}
