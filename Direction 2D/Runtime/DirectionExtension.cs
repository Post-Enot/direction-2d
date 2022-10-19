using System;
using UnityEngine;

namespace Direction2D
{
    public static class DirectionExtension
    {
        private const string _meaninglessValue = "�������� �� ����� ������ � ����� ������ ����������� � ������������.";

        /// <summary>
        /// ����������� �������� ����������� � ���� Vector2,
        /// ���� ��� ����� ����� � ����� ������ ����������� � ������������.
        /// </summary>
        /// <returns>���������� ��������������� �������� ���� Vector2, ���� ��� ����� ����� � ����� ������
        /// ����������� � ������������; ����� �������� InvalidCastException.</returns>
        /// <exception cref="InvalidCastException"></exception>
        public static Vector2 ToVector2(this Direction direction)
        {
            return direction switch
            {
                Direction.None                      => Vector2.zero,
                Direction.Up                        => Vector2.up,
                Direction.Down                      => Vector2.down,
                Direction.Left                      => Vector2.left,
                Direction.Right                     => Vector2.right,
                Direction.Up | Direction.Left       => new Vector2(-1, 1),
                Direction.Up | Direction.Right      => new Vector2(1, 1),
                Direction.Down | Direction.Left     => new Vector2(-1, -1),
                Direction.Down | Direction.Right    => new Vector2(1, -1),
                _                                   => throw new InvalidCastException(_meaninglessValue)
            };
        }

        /// <summary>
        /// ����������� �������� ����������� � ���� Vector2Int,
        /// ���� ��� ����� ����� � ����� ������ ����������� � ������������.
        /// </summary>
        /// <returns>���������� ��������������� �������� ���� Vector2Int, ���� ��� ����� ����� � ����� ������
        /// ����������� � ������������; ����� �������� InvalidCastException.</returns>
        /// <exception cref="InvalidCastException"></exception>
        public static Vector2Int ToVector2Int(this Direction direction)
        {
            return direction switch
            {
                Direction.None                      => Vector2Int.zero,
                Direction.Up                        => Vector2Int.up,
                Direction.Down                      => Vector2Int.down,
                Direction.Left                      => Vector2Int.left,
                Direction.Right                     => Vector2Int.right,
                Direction.Up | Direction.Left       => new Vector2Int(-1, 1),
                Direction.Up | Direction.Right      => new Vector2Int(1, 1),
                Direction.Down | Direction.Left     => new Vector2Int(-1, -1),
                Direction.Down | Direction.Right    => new Vector2Int(1, -1),
                _                                   => throw new InvalidCastException(_meaninglessValue)
            };
        }

        /// <summary>
        /// ����������� �������� ����������� � ���� Vector3,
        /// ���� ��� ����� ����� � ����� ������ ����������� � ������������.
        /// </summary>
        /// <returns>���������� ��������������� �������� ���� Vector3, ���� ��� ����� ����� � ����� ������
        /// ����������� � ������������; ����� �������� InvalidCastException.</returns>
        /// <exception cref="InvalidCastException"></exception>
        public static Vector3 ToVector3(this Direction direction)
        {
            return direction switch
            {
                Direction.None                      => Vector2.zero,
                Direction.Up                        => Vector2.up,
                Direction.Down                      => Vector2.down,
                Direction.Left                      => Vector2.left,
                Direction.Right                     => Vector2.right,
                Direction.Up | Direction.Left       => new Vector2(-1, 1),
                Direction.Up | Direction.Right      => new Vector2(1, 1),
                Direction.Down | Direction.Left     => new Vector2(-1, -1),
                Direction.Down | Direction.Right    => new Vector2(1, -1),
                _                                   => throw new InvalidCastException(_meaninglessValue)
            };
        }

        /// <summary>
        /// ����������� �������� ����������� � ���� Vector3Int,
        /// ���� ��� ����� ����� � ����� ������ ����������� � ������������.
        /// </summary>
        /// <returns>���������� ��������������� �������� ���� Vector3Int, ���� ��� ����� ����� � ����� ������
        /// ����������� � ������������; ����� �������� InvalidCastException.</returns>
        /// <exception cref="InvalidCastException"></exception>
        public static Vector3Int ToVector3Int(this Direction direction)
        {
            return direction switch
            {
                Direction.None                      => Vector3Int.zero,
                Direction.Up                        => Vector3Int.up,
                Direction.Down                      => Vector3Int.down,
                Direction.Left                      => Vector3Int.left,
                Direction.Right                     => Vector3Int.right,
                Direction.Up | Direction.Left       => new Vector3Int(-1, 1),
                Direction.Up | Direction.Right      => new Vector3Int(1, 1),
                Direction.Down | Direction.Left     => new Vector3Int(-1, -1),
                Direction.Down | Direction.Right    => new Vector3Int(1, -1),
                _                                   => throw new InvalidCastException(_meaninglessValue)
            };
        }

        /// <summary>
        /// ���������, ����� �� �������� ����� � ����� ������ ����������� � ������������.
        /// </summary>
        /// <returns>���������� true, ���� �������� ����� ����� � ����� ������ ����������� � ������������;
        /// ����� false.</returns>
        public static bool IsValueMakeSence(this Direction direction)
        {
            return  direction == Direction.None ||
                    direction == Direction.Up ||
                    direction == Direction.Down ||
                    direction == Direction.Left ||
                    direction == Direction.Right ||
                    direction == (Direction.Up | Direction.Left) ||
                    direction == (Direction.Up | Direction.Right) ||
                    direction == (Direction.Down | Direction.Left) ||
                    direction == (Direction.Down | Direction.Right);
        }
    }
}
